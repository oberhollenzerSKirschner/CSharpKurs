using System;
using System.Collections.Generic;
using System.Text;
using ItSchulung.CsharpKurs.InterfaceLibrary;

namespace InterfaceWinFormsApp.Prototype
{
    internal class HumanPrototype : IHuman
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateOnly DateOfBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Greet()
        {
            throw new NotImplementedException();
        }
    }
}
