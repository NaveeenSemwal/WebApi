using CMS.DB.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace CMS.DB.GenericRepository
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {

        private readonly eCommAdapter_DevEntities Context;
        private readonly IDbSet<Entity> Entities;
        string errorMessage = string.Empty;

        public GenericRepository(eCommAdapter_DevEntities context)
        {
            this.Context = context;
            this.Entities = context.Set<Entity>();
        }

       
        private static string PopulateEFerror(DbValidationError validationError)
        {
            return string.Format("Property: {0} Error: {1}",
                                    validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
        }
        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetch all record of entity
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Entity> GetAll()
        {
            return this.Entities.ToList();
        }

        /// <summary>
        /// Return single entity
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Entity GetById(object Id)
        {
            return this.Entities.Find(Id);
        }

        public void Insert(Entity obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new ArgumentNullException("obj");
                }
                this.Entities.Add(obj);
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += PopulateEFerror(validationError);
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }


        public void Save()
        {
            this.Context.SaveChanges();
        }

        public void Update(Entity obj)
        {
            throw new NotImplementedException();
        }
    }
}
