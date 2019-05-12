using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new ExampleContext())
            {
                var queryInsert = context.DbInsertTypes
                                              .Include(i => i.Inserts)
                                              .Include(x => x.CurrentTypeMill)
                                              .FirstOrDefault();

                var queryMill = context.DbMillingToolType
                                                .Include(i => i.MillingTools)
                                                .Include(x => x.TypeInserts)
                                                .FirstOrDefault();

                var getHolders = context.DbHolders.OrderBy(x => x.HolderOrderCode).FirstOrDefault();

                var queryMillHolder = context.DbHolders
                                                .Include(m => m.MillingTools)
                                                .ToList();
                
                foreach(var holder in queryMillHolder)
                {

                    Console.WriteLine(holder.HolderOrderCode);
                    foreach(var mill in holder.MillingTools)
                    {
                        Console.WriteLine(mill?.MillOrderCode);
                        foreach(var insert in mill.Inserts)
                        {
                            Console.WriteLine(insert.InsertCode);
                        }
                    }
                    Console.WriteLine();

                }
               
                foreach(var insert in queryInsert.Inserts)
                {
            //         Console.WriteLine(insert.InsertCode + " " + insert.CurrentInsertType.TypeInsertCode);
                   
                }

                foreach(var mill in queryMill.MillingTools)
                {
           //         Console.WriteLine(mill.MillOrderCode + " " + mill.CurrentTypeMill.TypeMillCode);

                }

            }

            Console.WriteLine("Ready.");
            Console.ReadLine();

        }
    }
}
