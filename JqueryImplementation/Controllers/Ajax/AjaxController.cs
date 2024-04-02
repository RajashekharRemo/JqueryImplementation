namespace JqueryImplementation.Controllers.Ajax
{
    using Microsoft.AspNetCore.Mvc;
    using RepositoryLayer;
    using RepositoryLayer.Entity;

    public class AjaxController : Controller
    {
        private readonly EmployeeContext _context;

        // <summary>
        // Initializes a new instance of the <see cref="AjaxController"/> class.
        // </summary>
        // <param name="employeeContext"></param>
        public AjaxController(EmployeeContext employeeContext)
        {
            this._context = employeeContext;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public JsonResult EmployeeList()
        {
            var data = this._context.EmployeeAjaxRef.ToList();

            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult AddEmployee(Employee employee)
        {
            Employee emp = new Employee()
            {
                Name = employee.Name,
                city = employee.city,
                State = employee.State,
                Salary = employee.Salary,
            };
            this._context.EmployeeAjaxRef.Add(emp);
            this._context.SaveChanges();
            return new JsonResult("Data is Saved");

        }

        public JsonResult Delete(int id)
        {
            var data = this._context.EmployeeAjaxRef.Where(e => e.Id == id).SingleOrDefault();
            this._context.EmployeeAjaxRef.Remove(data);
            this._context.SaveChanges();
            return new JsonResult("Data Deleted");
        }

        public JsonResult Edit(int id)
        {
            var data = this._context.EmployeeAjaxRef.Where(e => e.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }

        public JsonResult Update(Employee employee)
        {
            this._context.EmployeeAjaxRef.Update(employee);
            this._context.SaveChanges();
            return new JsonResult("Record Updated");

        }

    }
}
