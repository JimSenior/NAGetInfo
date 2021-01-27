using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NAGetInfo
{
    class Program
    {
        static  void Main(string[] args)
        {
            string output = "Not Sufficient Info";

            //Check that the args parameter has only 1 in it AND it contains the correct string - http://discovery.nationalarchives.gov.uk/API/records/v1/details/
            if (args.Length != 1 || (args.Length == 1 && !args[0].Contains(@"http://discovery.nationalarchives.gov.uk/API/records/v1/details/") ))
            {
                output = "Please enter a valid api call";
            }
            else
            {
                var url = args[0];
                var record = GetRecord(url);

                if (record.Result != null)
                {
                    output = (string)record.Result.title ?? record.Result.scopeContent.description ?? record.Result.citableReference;

                    //*************************************
                    //if (record.Result.title!=null)
                    //{
                    //    output = record.Result.title.ToString();
                    //}
                    //else
                    //{
                    //    if (!string.IsNullOrEmpty(record.Result.scopeContent.description))
                    //    {
                    //        output = record.Result.scopeContent.description;
                    //    }
                    //    else
                    //    {
                    //        if (!string.IsNullOrEmpty(record.Result.citableReference))
                    //        {
                    //            output = record.Result.citableReference;
                    //        }
                    //    }
                    //}
                    //***************************************
                }
                else
                {
                    output = "No Record found";
                }
            }
            Console.WriteLine(output);
        }


        protected async static Task<Record> GetRecord(string url)
        {
            HTTPClient client = new HTTPClient();
            var data = await client.GetData(url);
            var record = JsonConvert.DeserializeObject<Record>(data);
            return record;
        }


    }
}
