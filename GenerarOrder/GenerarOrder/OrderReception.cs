using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBDD;

namespace GenerarOrder
{
    public class OrderReception
    {
        SecureContext db = new SecureContext();
        Orders order = new Orders();
        OrderInfo info = new OrderInfo();
        OrdersDetail detail = new OrdersDetail();
        const string orderString = "ORDERS_D_96A_UN_EAN008";
        const string dadesGenerals = "ORD";
        const string dates = "DTM";
        const string emisor = "NADMS";
        const string receptor = "NADMR";
        const string idAtricle = "LIN";
        const string quantitat = "QTYLIN";
        const string dataEntrega = "DTMLIN";

        public bool GenerarComanda(string archivo)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(archivo);
            string line = file.ReadLine();
            if (line == orderString)
            {
                while ((line = file.ReadLine()) != null)
                {
                    
                    string[] lineInfo = line.Split('|');
                    string etiqueta = lineInfo[0];
                    string code1 = lineInfo[1], code2 = "", code3 = "";

                    if (etiqueta == dadesGenerals)
                    {
                        code2 = lineInfo[2];
                        if(!db.Orders.Any(o=>o.codeOrder == code1))
                        {
                            order.codeOrder = code1;
                            order.Priority = db.Priority.Where(o => o.CodePriority == code2).FirstOrDefault();
                        }
                        else
                        {
                            file.Close();
                            return true;
                        }
                    }
                    else if (etiqueta == dates)
                    {
                        order.dateOrder = DateTime.ParseExact(code1, "yyyyMMdd", CultureInfo.InvariantCulture);
                    }
                    else if (etiqueta == emisor)
                    {
                        code2 = lineInfo[2];
                        info.OperationalAreas = db.OperationalAreas.Where(o => o.CodeOperationalArea == code1).FirstOrDefault();
                        info.Agencies = db.Agencies.Where(o => o.CodeAgency == code2).FirstOrDefault();
                    }
                    else if (etiqueta == receptor)
                    {
                        order.Factories = db.Factories.Where(o => o.codeFactory == code1).FirstOrDefault();
                        db.Orders.Add(order);
                        db.SaveChanges();

                        info.Orders = db.Orders.ToList().LastOrDefault();
                        db.OrderInfo.Add(info);

                        db.SaveChanges();
                    }
                    else if (etiqueta == idAtricle)
                    {
                        detail = new OrdersDetail();
                        detail.Orders = db.Orders.ToList().LastOrDefault();

                        code2 = lineInfo[2];
                        code3 = lineInfo[3];

                        detail.Planets = db.Planets.Where(o => o.CodePlanet == code1).FirstOrDefault();
                        detail.References = db.References.Where(o => o.codeReference == code2).FirstOrDefault();

                    }
                    else if (etiqueta == quantitat)
                    {
                        code2 = lineInfo[2];
                        detail.Quantity = short.Parse(code2);
                    }
                    else if (etiqueta == dataEntrega)
                    {
                        detail.DeliveryDate = DateTime.ParseExact(code1, "yyyyMMdd", CultureInfo.InvariantCulture);
                        db.OrdersDetail.Add(detail);
                        db.SaveChanges();
                    }
                }
                if(order != null && info != null && detail != null)
                {
                    file.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}

