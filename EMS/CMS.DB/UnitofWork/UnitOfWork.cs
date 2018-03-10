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
        private IGenericRepository<Category> _categoryRepository;


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
        public IGenericRepository<Category> CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new GenericRepository<Category>(context);
                }
                return _categoryRepository;
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
