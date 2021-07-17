using ExampleofJavaFunctionUsingJavascriptClass.Client.AllData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleofJavaFunctionUsingJavascriptClass.Client.Pages
{
    public partial class Index
    {
        private List<Data> d;
        protected override void OnInitialized()
        {
            d = new List<Data>()
            {

            new Data() { Id = 101, Name = "Aman", Address = "Noida" },
                new Data() { Id = 102, Name = "manish", Address = "Gr Noida" },
                new Data() { Id = 103, Name = "Ajay", Address = "Noida" },
                new Data() { Id = 104, Name = "Vijay", Address = "Gr Noida" }
            };
        }
        private async Task DeleteAsync(Data d1)
        {

            var confirmed = await js.Confirm($"Are You Sure Want to Delete{d1.Id}{d1.Name}{d1.Address}");
            if (confirmed)
            {
                d.Remove(d1);
            }
        }
        public bool check;
    
}
}
