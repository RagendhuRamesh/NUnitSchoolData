using ClassLibSchoolData;
using Moq;
namespace ClassLibSchoolData
{ 
    [TestFixture]
public class Tests
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TeacherNullTest()
    {
        foreach (var s in Schools.allTeacher())
        {


            Assert.IsNotNull(s.Tid);
            Assert.IsNotNull(s.TeacherName);
        }
    }
    [Test]
    public void StudentNull()
    {
        int RollNumber = 1;
            Assert.IsNotNull(Schools.EmpById(RollNumber));
        }
    [Test]
    public void MoqTeacherName()
    {
        var Tname = new Mock<Teachers>();
        var teacher = Tname.Object;
        Assert.IsNotNull(teacher);
    }
}
}
