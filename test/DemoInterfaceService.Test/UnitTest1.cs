using DemoInterfaceService.Controllers;
using DemoInterfaceService.Models.Entities;
using DemoInterfaceService.Repositories.Khoas;
using Microsoft.AspNetCore.Mvc;
using Moq;


namespace DemoInterfaceService.Test
{
    public class UnitTest1
    {
        //code here


        [Fact]
        public void CallGetAllKhoa()
        {
            //Arrange
            var mock = new Mock<IKhoaRepository<Khoa, Guid>>();

            mock.Setup(x => x.GetAll());

            var controller = new KhoaController(mock.Object);

            //act
            var result = controller.GetAllKhoa();

            var model = Assert.IsType<Task<IActionResult>>(result);
            //Assert
            Assert.Equal(true, model.IsCompletedSuccessfully);
        }

        [Fact]
        public void CallGetByIdKhoa()
        {
            //Arrange
            var id = new Guid();
            var mock = new Mock<IKhoaRepository<Khoa, Guid>>();

            mock.Setup(x => x.GetAll());

            var controller = new KhoaController(mock.Object);

            //act
            var result = controller.GetKhoaId(id);

            var model = Assert.IsType<Task<IActionResult>>(result);
            //Assert
            Assert.Equal(true, model.IsCompletedSuccessfully);
        }
    }
}