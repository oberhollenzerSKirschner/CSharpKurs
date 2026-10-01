using ItSchulung.CsharpKurs.ClassLibrary;

namespace LibaryTestProject
{
    public class EmployeeTest
    {
        [Fact]
        public void TestInvalid_Age()
        {
            Employee employee = new Employee();
            var exeption = Assert.Throws<EmployeeToYoungEception>(() => employee.DateOfBirth = new DateOnly(2022, 02, 20));  //DateOnly.FromDateTime(DateTime.Now.AddYears(-17)));
            
            Assert.Equal("Mitarbeiter muss mindestens 15 Jahre alt sein.", exeption.Message); 
            //Assert.Equal("Employee is too young", exeption.Message);
        }
    }
}
