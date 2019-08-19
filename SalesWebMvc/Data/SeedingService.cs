using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
             if( _context.Department.Any() ||
                 _context.Seller.Any()||
                 _context.SalesRecord.Any())
             {
                 return; // db ja foi populado
             }

              Department d1 = new Department(0, "Computers");
              Department d2 = new Department(0, "Eletronics");
              Department d3 = new Department(0, "Fashion");
              Department d4 = new Department(0, "Books");
            
             Seller s1 = new Seller(0 ,"Bob Brown", "bob@hotmail.com", new DateTime(1980,4,21), 1000.0, d1);
             Seller s2 = new Seller(0 ,"Maria", "maria@hotmail.com", new DateTime(1979, 4, 21), 3000.0, d2);
             Seller s3 = new Seller(0 ,"Paulo", "paulo@hotmail.com", new DateTime(1980, 4, 21), 1600.0, d1);
             Seller s4 = new Seller(0 ,"Pedro", "pedro@hotmail.com", new DateTime(1980, 4, 21), 1000.0, d4);
             Seller s5 = new Seller(0 ,"Bia", "bia@hotmail.com", new DateTime(1980, 4, 21), 2000.0, d3);
             Seller s6 = new Seller(0 ,"Laura", "laura@hotmail.com", new DateTime(1980, 4, 21), 8000.0, d2);
            
              SalesRecord r1 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r2 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s4);
              SalesRecord r3 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s2);
              SalesRecord r4 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r5 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s3);
              SalesRecord r6 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s5);
              SalesRecord r7 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s6);
              SalesRecord r8 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s6);
              SalesRecord r9 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r10 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s6);
              SalesRecord r11 = new SalesRecord(0, new DateTime(2018, 08, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r12 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s2);
              SalesRecord r13 = new SalesRecord(0, new DateTime(2018, 07, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r14 = new SalesRecord(0, new DateTime(2018, 06, 25), 11000.0,  SaleStatus.Billed, s3);
              SalesRecord r15 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s4);
              SalesRecord r16 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r17 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r18 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r19 = new SalesRecord(0, new DateTime(2018, 10, 25), 11000.0,  SaleStatus.Pending, s1);
              SalesRecord r20 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r21 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r22 = new SalesRecord(0, new DateTime(2018, 11, 25), 11000.0,  SaleStatus.Billed, s2);
              SalesRecord r23 = new SalesRecord(0, new DateTime(2018, 09, 20), 11000.0,  SaleStatus.Pending, s1);
              SalesRecord r24 = new SalesRecord(0, new DateTime(2018, 09, 26), 11000.0,  SaleStatus.Billed, s2);
              SalesRecord r25 = new SalesRecord(0, new DateTime(2018, 09, 21), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r26 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r27 = new SalesRecord(0, new DateTime(2018, 09, 24), 11000.0,  SaleStatus.Billed, s3);
              SalesRecord r28 = new SalesRecord(0, new DateTime(2018, 09, 26), 11000.0,  SaleStatus.Billed, s1);
              SalesRecord r29 = new SalesRecord(0, new DateTime(2018, 09, 22), 11000.0,  SaleStatus.Billed, s4);
              SalesRecord r30 = new SalesRecord(0, new DateTime(2018, 09, 23), 11000.0,  SaleStatus.Billed, s1);

             
            _context.Department.AddRange(d1,d2,d3,d4);
            
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            
            _context.SalesRecord.AddRange(
                r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,
                r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,
                r21,r22,r23,r24,r25,r26,r27,r28,r29,r30
                );
                 
            _context.SaveChanges(); 

        }
    }
}
