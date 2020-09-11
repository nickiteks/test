using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using bussines.Interfaces;
using databaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace databaseImplement.Implements
{
    public class BackUpLogic : IBackUp
    {
        public void SaveXmlGroup(string FolderName)
        {
            string fileNameDop = $"{FolderName}\\Groups.xml";
            using (var context = new Database())
            {
                XmlSerializer fomatterXml = new XmlSerializer(typeof(DbSet<Group>));
                using (FileStream fs = new FileStream(fileNameDop, FileMode.Create))
                {
                    fomatterXml.Serialize(fs, context.Groups);
                }
            }
        }
        public void SaveXmlStudent(string FolderName)
        {
            string fileNameDop = $"{FolderName}\\Students.xml";
            using (var context = new Database())
            {
                XmlSerializer fomatterXml = new XmlSerializer(typeof(DbSet<Student>));
                using (FileStream fs = new FileStream(fileNameDop, FileMode.Create))
                {
                    fomatterXml.Serialize(fs, context.Students);
                }
            }
        }
    }
}
