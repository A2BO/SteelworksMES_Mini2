﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniSteelworksMES.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MesEntities : DbContext
    {
        public MesEntities()
            : base("name=MesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public virtual DbSet<GrossProfit> GrossProfits { get; set; }
        public virtual DbSet<GrowthRate> GrowthRates { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Origin> Origins { get; set; }
        public virtual DbSet<OriginQuantity> OriginQuantities { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<ProductWareHouse> ProductWareHouses { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Resource_Quote> Resource_Quotes { get; set; }
        public virtual DbSet<ResourceWareHouse> ResourceWareHouses { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}
