using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FormFactory.Attributes;

namespace ParcelHubDemo.Models
{
    public class EDIModel
    {
        public EDIModel()
        {

            
        }

        [Required]
        [Display(Prompt = "Type to find your location")]
        public string Location { get; set; }
        public IEnumerable<string> Location_suggestions()
        {
            return CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(c => c.Name).Distinct();
        }

        [Required]
        [Display(Name = "What is your home country?", Prompt = "Type to find your location")]
        [Description("AJAX suggestions using [SuggestionsUrl(\"...someurl...\")]")]
        [SuggestionsUrl("/home/CountrySuggestions")]
        public string CountryViaAjax { get; set; }

    }
}
