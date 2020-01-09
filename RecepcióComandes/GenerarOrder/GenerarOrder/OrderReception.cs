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
        SContext db = new SContext();
        Orders order = new Orders();
        OrdersDetail detail;
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
                        order.OperationalAreas = db.OperationalAreas.Where(o => o.CodeOperationalArea == code1).FirstOrDefault();
                        order.Agencies = db.Agencies.Where(o => o.CodeAgency == code2).FirstOrDefault();
                    }
                    else if (etiqueta == receptor)
                    {
                        order.Factories = db.Factories.Where(o => o.codeFactory == code1).FirstOrDefault();
                        db.Orders.Add(order);
                        
                    }
                    else if (etiqueta == idAtricle)
                    {
                        detail = new OrdersDetail();

                        code2 = lineInfo[2];
                        code3 = lineInfo[3];

                        detail.Planets = db.Planets.Where(o => o.CodePlanet == code1).FirstOrDefault();
                        detail.Referencess = db.Referencess.Where(o => o.CodeReference == code2).FirstOrDefault();
                    }
                    else if (etiqueta == quantitat)
                    {
                        int quantity;
                        if (code1 == "61")
                        {
                            quantity = int.Parse(lineInfo[2]) * -1;
                        }
                        else
                        {
                            quantity = int.Parse(lineInfo[2]);
                        }
                        detail.Quantity = short.Parse(quantity.ToString());
                    }
                    else if (etiqueta == dataEntrega)
                    {
                        detail.DeliveryDate = DateTime.ParseExact(code1, "yyyyMMdd", CultureInfo.InvariantCulture);
                        order.OrdersDetail.Add(detail);
                        db.SaveChanges();
                    }
                }
                if(order != null)
                {
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
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

