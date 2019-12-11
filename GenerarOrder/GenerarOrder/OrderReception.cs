﻿using System;
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
        const string orderString = "ORDERS_D_96A_UN_EAN008";
        const string dadesGenerals = "ORD";
        const string dates = "DTM";
        const string emisor = "NADMS";
        const string receptor = "NADMR";
        const string idAtricle = "LIN";
        const string quantitat = "QTYLIN";
        const string dataEntrega = "DTMLIN";

        private void GenerarComanda()
        {
            Orders order = new Orders();
            OrderInfo orderInfo = new OrderInfo();
            OrdersDetail detail;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\admin\Desktop\new1.edi");
            string line = file.ReadLine();
            if (line == orderString)
            {

                while ((line = file.ReadLine()) != null)
                {
                    string[] lineInfo = line.Split('|');
                    string etiqueta = lineInfo[0];

                    if (etiqueta == dadesGenerals)
                    {
                        order.codeOrder = lineInfo[1];
                        order.IdPriority = getPriority(lineInfo[2]);
                    }
                    else if (etiqueta == dates)
                    {
                        order.dateOrder = DateTime.ParseExact(lineInfo[1], "yyyyMMdd", CultureInfo.InvariantCulture);
                    }
                    else if (etiqueta == emisor)
                    {
                        orderInfo.idOperationalArea = getOperationalArea(lineInfo[1]);
                        orderInfo.idAgency = getAgency(lineInfo[2]);
                    }
                    else if (etiqueta == receptor)
                    {
                        order.IdFactory = getFactory(lineInfo[1]);
                        db.Orders.Add(order);
                    }
                    else if (etiqueta == idAtricle)
                    {
                        detail = new OrdersDetail();
                        //detail.idPlanet = getPlanet(lineInfo[1]);
                    }


                }
            }
        }

        private short getPriority(string _codePriority)
        {
            foreach (Priority priority in db.Priority)
            {
                if (_codePriority == priority.CodePriority)
                {
                    return priority.idPriority;
                }
            }
            return 0;
        }

        //private short getCampo(string code, string tabla)
        //{
        //    Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == tabla);
        //    Type[] typeParameters = type.GetGenericArguments(); 
        //    foreach(var type in typeParameters)
        //    {

        //    }



        //Type type = tabla.GetType();
        //string tableName = type.Name;
        //PropertyInfo tableProp = typeof(secureCoreEntities).GetProperty(tableName);
        //Type tableType = tableProp.PropertyType;

        //ParameterExpression p = Expression.Parameter(tabla.GetType());
        //Expression property = Expression.Property(p, "code"+tableName);
        //Expression c = Expression.Constant(code);
        //Expression body = Expression.Equal(property, c);
        //Expression exp = Expression.Lambda(body, new ParameterExpression[] { p });

        //MethodInfo singleMethod = typeof(Queryable).GetMethods()
        //    .Single(m => m.Name == "Single" && m.GetParameters().Count() == 2)
        //    .MakeGenericMethod(domainObject.GetType());

        //DbSet dbSet = context.Set(domainObject.GetType());
        //object entity = singleMethod.Invoke(null, new object[] { dbSet, exp });

        //}

        private short getOperationalArea(string _codeOperationalArea)
        {
            foreach (OperationalAreas area in db.OperationalAreas)
            {
                if (_codeOperationalArea == area.CodeOperationalArea)
                {
                    return area.idOperationalArea;
                }
            }
            return 0;
        }

        private short getAgency(string _codeAgency)
        {
            foreach (Agencies agency in db.Agencies)
            {
                if (_codeAgency == agency.CodeAgency)
                {
                    return agency.idAgency;
                }
            }
            return 0;
        }

        private short getFactory(string _codeFactory)
        {
            foreach (Factories factory in db.Factories)
            {
                if (_codeFactory == factory.codeFactory)
                {
                    return factory.idFactory;
                }
            }
            return 0;
        }


    }
}

