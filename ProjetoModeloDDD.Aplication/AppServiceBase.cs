

using System;
using ProjetoModeloDDD.Aplication.Interfaces;

namespace ProjetoModeloDDD.Aplication
{
    public class AppServiceBase <TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
