using System.ComponentModel.DataAnnotations;

namespace Silicon_WebApp.Filters
{
    public class CheckBoxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value) => value is bool b && b;
    }
}
