//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using System;
using System.Net.Http;

namespace Groove.Client
{
    public abstract class GrooveClientBase : IDisposable
    {
        readonly HttpClient client;

        protected GrooveClientBase()
        {
            this.client = new HttpClient();
        }

        protected HttpClient Client { get { return this.client; } }

        public void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.client != null) { this.client.Dispose(); }
            }
        }
    }
}