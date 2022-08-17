using Acme.SimpleTaskApp.Controllers;
using Acme.SimpleTaskApp.Tasks;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Acme.SimpleTaskApp.Web.Tests.Controllers
{
    public class TasksController_Tests : SimpleTaskAppWebTestBase
    {
        [Fact]
        public async System.Threading.Tasks.Task Should_Get_Tasks_By_State()
        {
            //Act

            var response = await GetResponseAsStringAsync(
                GetUrl<TasksController>(nameof(TasksController.Index), new
                {
                    state = TaskState.Open
                }
                )
            );

            //Assert

            response.ShouldNotBeNullOrWhiteSpace();

        }
    }
}

