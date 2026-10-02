using System;
using System.Collections.Generic;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = true)]

    public class DeveloperInfo : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the developer.
        /// </summary>
        public string DeveloperName { get; set; }
        /// <summary>
        /// Gets or sets the email address of the developer.
        /// </summary>
        public string DeveloperEmail { get; set; }
        /// <summary>
        /// Gets or sets the company of the developer.
        /// </summary>
        public string DeveloperCompany { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperInfo"/> class with the specified developer information.
        /// </summary>
        /// <param name="developerName"></param>
        /// <param name="developerEmail"></param>
        /// <param name="developerCompany"></param>
        public DeveloperInfo(string developerName, string developerEmail, string developerCompany)
        {
            DeveloperName = developerName;
            DeveloperEmail = developerEmail;
            DeveloperCompany = developerCompany;
        }
    }
}
