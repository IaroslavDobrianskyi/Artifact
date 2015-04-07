using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Art.Models;

namespace Art
{
    class App_code
    {
        public void Run(int c, int kStep, int kAct)
        {
            // c- threads count
            int[] par = new int[3];
            par[1] = kStep;
            par[2] = kAct;
            //for (int i=1;i<=c;i++)
            //{
                par[0] = 1;
                Thread thread1 = new Thread(PutFlow);
                thread1.Start(par);
                par[0] = 2;
                Thread thread2 = new Thread(PutFlow);
                thread2.Start(par);
                Console.ReadLine();
            //}
        }

        private void PutFlow(object obj)
        {
            int[] p =(int[]) obj;
Console.WriteLine("Ідентифікатор {0} :", Thread.CurrentThread.ManagedThreadId);
           // p[0] - user ID
           // p[1] - steps count
           // p[2] - actions count
            int parUser = p[0];
            int kStep = p[1];
            int kAct = p[2];
            DateTime t1 = DateTime.Now;
            DateTime t2 = DateTime.Now;
            int fIdStep = 1;
            int fIdAct = 101;
            int fIdFlow = 1001;
            int ActFlow;

            using (artEntities db = new artEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Step StepNext = db.Steps.Add(new Step { id = fIdStep, idUser = parUser });
                        for (int k = 1; k <= kStep; k++)
                        {
                            ActFlow = fIdAct;
                            for (int i = 1; i <= kAct; i++)
                            {
                                Art.Models.Action NextAct = db.Actions.Add(new Art.Models.Action { id = fIdAct, idUser = parUser, idStep = fIdStep });
                                fIdAct++;
                            }

                            Step StepNext1 = db.Steps.Add(new Step { id = fIdStep + 1, idUser = parUser });
                            ActFlow FixFlow = db.ActFlows.Add(new ActFlow { id = fIdFlow, idUser = parUser, idStep = fIdStep + 1, idAction = ActFlow });
                            db.SaveChanges();
                            StepNext = db.Steps.Where(s => s.id == fIdStep & s.idUser == parUser).First();
                            StepNext.idActFlow = fIdFlow;
                            db.SaveChanges();
                            fIdStep++;
                            fIdFlow++;
                        }
                        t2 = DateTime.Now;

                        Statistic NextStat = db.Statistics.Add(new Statistic { idUser = parUser, kStep = kStep, kAct = kAct, time = (t2 - t1).Milliseconds, nStep = 1, nAct = 101 });
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }

            }
        }
       
    }
}
