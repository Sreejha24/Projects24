using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LinqQuery
{
    public class Class1
    {
        public void Query()
        {
            DataTable dataTable = new DataTable("StudentDetails");
            DataColumn Auto = new DataColumn("Auto", typeof(int));
            dataTable.Columns.Add(Auto);
            DataColumn Name = new DataColumn("Name", typeof(string));
            dataTable.Columns.Add(Name);
            DataColumn Gender = new DataColumn("Gender", typeof(char));
            dataTable.Columns.Add(Gender);
            DataColumn DOB = new DataColumn("DOB", typeof(string));
            dataTable.Columns.Add(DOB);
            DataColumn Mobile = new DataColumn("Mobile", typeof(long));
            dataTable.Columns.Add(Mobile);
            DataColumn Qualification = new DataColumn("Qualification", typeof(string));
            dataTable.Columns.Add(Qualification);
            Auto.AutoIncrement = true;
            Auto.AutoIncrementSeed = 1;
            Auto.ReadOnly = true;
            Auto.Unique = true;
            DataColumn[] PK = new DataColumn[1];
            PK[0] = Auto;
            dataTable.PrimaryKey = PK;
            DataRow dataRow = null;
            for (int i = 1; i < 4; i++)
            {
                dataRow = dataTable.NewRow();
                dataRow["Auto"] = 1;
                //dataTable.Rows.Add(dataRow);
            }
            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Sai";
            dataRow["Gender"] = "M";
            dataRow["DOB"] = "1973-07-07";
            dataRow["Mobile"] = "1232564667";
            dataRow["Qualification"] = "B.tech";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Sreejha";
            dataRow["Gender"] = "F";
            dataRow["DOB"] = "1998-04-24";
            dataRow["Mobile"] = "199982564667";
            dataRow["Qualification"] = "M.tech";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Chaithanya";
            dataRow["Gender"] = "M";
            dataRow["DOB"] = "1999-05-25";
            dataRow["Mobile"] = "9232564667";
            dataRow["Qualification"] = "B.tech";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Vijaya";
            dataRow["Gender"] = "F";
            dataRow["DOB"] = "1977-05-25";
            dataRow["Mobile"] = "9432564667";
            dataRow["Qualification"] = "Degree";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Dr.Ganesh";
            dataRow["Gender"] = "F";
            dataRow["DOB"] = "1999-10-19";
            dataRow["Mobile"] = "9472564667";
            dataRow["Qualification"] = "Phd";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Geethika";
            dataRow["Gender"] = "F";
            dataRow["DOB"] = "1999-07-30";
            dataRow["Mobile"] = "9232564577";
            dataRow["Qualification"] = "B.tech";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Roshini";
            dataRow["Gender"] = "F";
            dataRow["DOB"] = "1999-10-29";
            dataRow["Mobile"] = "9232555667";
            dataRow["Qualification"] = "BA";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Karthik";
            dataRow["Gender"] = "F";
            dataRow["DOB"] = "1999-01-28";
            dataRow["Mobile"] = "9232344667";
            dataRow["Qualification"] = "B.tech";
            dataTable.Rows.Add(dataRow);

            dataRow = dataTable.NewRow();
            dataRow["Name"] = "Ravi Teja";
            dataRow["Gender"] = "F";
            dataRow["DOB"] = "1999-12-19";
            dataRow["Mobile"] = "9232534667";
            dataRow["Qualification"] = "BSc";
            dataTable.Rows.Add(dataRow);

            dataTable.Rows.Add(13, "Krishna", "M", "1999-07-21", "9987654658", "Degree");
            dataTable.Rows.Add(14, "Vinuthna", "F", "1998-04-19", "9098765658", "BA");

            dataTable.Rows[9]["Name"] = "Krishna";
            dataTable.Rows[9]["DOB"] = "1999-06-14";
            dataTable.AcceptChanges();

            dataTable.Rows[7]["Name"] = "Karthik";
            dataTable.Rows[7]["Gender"] = "M";
            dataTable.AcceptChanges();

            dataTable.Rows[8]["Name"] = "Ravi Teja";
            dataTable.Rows[8]["Gender"] = "M";
            dataTable.AcceptChanges();

            dataTable.Rows[4]["Name"] = "Dr.Ganesh";
            dataTable.Rows[4]["Gender"] = "M";
            dataTable.AcceptChanges();

            dataTable.Rows[1]["Name"] = "Sreejha";
            dataTable.Rows[1]["Mobile"] = "9678543243";
            dataTable.AcceptChanges();

            dataTable.Rows[10].Delete();
            dataTable.AcceptChanges();

            DataView dataView = new DataView(dataTable);
            dataView.Sort = "Gender DESC, Name Desc";
            //foreach (DataRowView view in dataView)
            //{
            //    Console.WriteLine(view["DOB"].ToString());
            //}
            //DataRow[] rows33 = dataTable.Select("Auto = max(Auto)");
            //string str = "MaxAutoId: " + rows33[0]["auto"].ToString();
            //Console.WriteLine(str);

            object objSum = dataTable.Compute("sum(Auto)", "Auto>7");
            object objsum = dataTable.Compute("sum(Auto)", "");
            string sum = "Sum:" + objsum.ToString();
            Console.WriteLine(sum);



            //DataRow[] rows = dataTable.Select("Gender = 'F'");
            //DataRow[] rows1 = dataTable.Select("Gender = 'M'", "Gender ASC");
            DataRow[] rows2 = dataTable.Select("Gender = 'F'", "Gender DESC");
            //for (int i = 0; i < rows.Length; i++)
            //{
            //    Console.WriteLine(rows2[i]["name"].ToString());
            //}
            //dataRow = dataTable.NewRow();
            DataTable datatable1 = dataTable.Clone();
            foreach (DataRow i in rows2)
            {
                datatable1.Rows.Add(i.ItemArray);
            }
            //foreach (DataRow i in datatable1.Rows)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("Auto" + "\t|\t" + "Name" + "     \t|\t" + "Gender" + "\t|\t" + "DOB" + "      \t|\t" + "Mobile" + "   \t|\t" + "Qualification");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["Auto"] + "\t|\t" + row["Name"] + "     \t|\t" + row["Gender"] + "\t|\t" + row["DOB"] + "\t|\t" + row["Mobile"] + "\t|\t" + row["Qualification"]);
            }
        }
    }
}
