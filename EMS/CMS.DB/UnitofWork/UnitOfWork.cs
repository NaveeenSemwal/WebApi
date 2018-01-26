using CMS.DB.DataModel;
using CMS.DB.GenericRepository;
using System;
using System.Diagnostics;

namespace CMS.DB
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly eCommAdapter_DevEntities context;
        private bool disposed;
        private IGenericRepository<ClientRequestAlia> _clientRequestAliasRepository;


        public UnitOfWork(eCommAdapter_DevEntities context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context was not supplied");
            }

            this.context = context;
        }

        public UnitOfWork()
        {
            context = new eCommAdapter_DevEntities();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #region IUnitOfWork Members
        public IGenericRepository<ClientRequestAlia> ClientRequestAliasRepository
        {
            get
            {
                if (_clientRequestAliasRepository == null)
                {
                    _clientRequestAliasRepository = new GenericRepository<ClientRequestAlia>(context);
                }
                return _clientRequestAliasRepository;
            }
        }
        #endregion

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                    Debug.WriteLine("UnitOfWork is being disposed");
                }
            }
            disposed = true;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
