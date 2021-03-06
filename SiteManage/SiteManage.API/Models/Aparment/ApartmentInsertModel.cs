using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ApartmentInsertModel

{
    [Required(ErrorMessage = "{0} is required.")]
    [RegularExpression("^([A-Z]{1})$", ErrorMessage = "Apartment block must be A-Z.")]
    public string Block { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    //[RegularExpression("^([1-99])$", ErrorMessage = "Apartment number must be 1-99.")]
    [RegularExpression("^0*(?:[1-9][0-9]?|100)$", ErrorMessage = "Apartment number must be 1-99.")]
    public int Number { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [RegularExpression("^([1-99])$", ErrorMessage = "Apartment floor must be 1-99.")]
    public int Floor { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public int? ResidentId { get; set; }

    [Required(ErrorMessage = "{0} is required.")]
    [RegularExpression("^([0-9]{1})[+]([1-6]{1})$", ErrorMessage = "Apartment type must be 0+1 - 9+6")]
    public string Type { get; set; }

    public bool IsEmpty { get; set; }
}
