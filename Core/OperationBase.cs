﻿using Core.Abstract;
using Core.Event;
using Core.Result;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Core
{
    public abstract class OperationBase<TRequest, TResponse>
        where TRequest : Request
    {
        protected virtual void Before(TRequest request) { }
        protected virtual void After(TRequest request) { }

        protected virtual void Exception(TRequest request, Exception e) { }
        protected abstract TResponse Execute(TRequest request);
        public DataResponse<TResponse> Operation(TRequest request)
        {
            Console.WriteLine($"Request Json {request.Guid}: {JsonConvert.SerializeObject(request)}");
            try
            {
                Before(request);
                TResponse response = Execute(request);
                After(request);
                Console.WriteLine($"Response Json {request.Guid}: {JsonConvert.SerializeObject(response)}");
                Completed(request);
                return new SuccessResponse<TResponse>(response);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Request Error {request.Guid} {ex.Message} ");
                Exception(request, ex);
                return new ErrorReponse<TResponse>(ex.Message);
            }
            finally { }
        }

        private void Completed(TRequest request)
        {
            foreach (IEvent @event in request.Events)
            {
                Console.WriteLine(new string('*', 50));
                Console.WriteLine($"Request Json {@event.GetType().Name} Start");
                @event.Execute();
                Console.WriteLine($"Request Json {@event.GetType().Name} End ");
            }
        }
    }
}
