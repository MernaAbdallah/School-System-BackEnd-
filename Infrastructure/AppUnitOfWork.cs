using Infrastructure.Context;
using Infrastructure.Repositories;

using Domain.EnrollmentAggregate;

using System;

namespace Infrastructure
{
    public class AppUnitOfWork : IDisposable
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;

        public AppUnitOfWork(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            ManagerRep = new ManagerRepository(_context);
            SchoolRep = new SchoolRepository(_context);
            TeacherRep = new TeacherRepository(_context);
        }

        public ISchoolRepository SchoolRep { get; }
        public ITeacherRepository TeacherRep { get; }
        public IManagerRepository ManagerRep { get; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
