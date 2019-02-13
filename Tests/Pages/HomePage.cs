using BaseSetup.Page;
using BaseSetup.UpgradedSelenium;
using OpenQA.Selenium;

namespace Tests.Pages
{
    public class HomePage : BasePage
    { 
        
        //search for cars
      
    
        public override string pageUrl { get; set; } = "https://www.phptravels.net/";

        public UpWebElement CarsSearch => Driver.FindElement(By.CssSelector("[href='#cars']"));

        public UpWebElement PickUpDate => Driver.FindElement(By.Id("departcar"));
        
        public UpWebElement PickUpTime => Driver.FindElement(By.Name("pickupTime"));
        
        public UpWebElement DropOffDate => Driver.FindElement(By.Id("returncar"));
        
        public UpWebElement DropOffTime => Driver.FindElement(By.Name("dropoffTime"));

        public UpWebElement SearchButtonCars => Driver.FindElements(By.CssSelector(".btn-block.pfb0.loader"))[2];

        public UpWebElement SearchCarsForm => Driver.FindElement(By.Id("cars"));

        public UpWebElement SearchCarsFormPickUpLocation => SearchCarsForm.FindElements(By.CssSelector(".col-md-2.form-group.go-right.col-xs-12"))[0];

        public UpWebElement SearchCarsFormPickUpLocationField => Driver.FindElement(By.Id("select2-drop"));

        public UpWebElement SearchCarsFormPickUpLocationInputField => SearchCarsFormPickUpLocationField.FindElement(By.TagName("input"));

        public UpWebElement SearchCarsFormDropOffLocationField => SearchCarsForm.FindElements(By.CssSelector(".col-md-2.form-group.go-right.col-xs-12"))[1];

        //search for hotels

       

        public UpWebElement Flights => Driver.FindElement(By.CssSelector("[href='#flights']"));

      //  public UpWebElement AirportNameInputField => Driver.FindElements(By.CssSelector("select2-drop-active"))[1];

       public UpWebElement CityAirportFrom => Driver.FindElement(By.Id("s2id_location_from"));

        public UpWebElement CityAirportFromInputField => Driver.FindElement(By.Id("s2id_autogen12"));

        public UpWebElement CityAirportTo => Driver.FindElement(By.Id("s2id_location_to"));

        public UpWebElement CityAirportToInputField => Driver.FindElement(By.Id("s2id_autogen13"));

        public UpWebElement CityAirportFromSelection => Driver.FindElement(By.CssSelector(".select2-results"));
            
        public UpWebElement DepartureDate => Driver.FindElement(By.Name("departure"));

        public UpWebElement PassengersSelection => Driver.FindElement(By.Name("totalManualPassenger"));

        public UpWebElement AdultsNumber => Driver.FindElement(By.Name("madult"));

        public UpWebElement ChildrenNumber => Driver.FindElement(By.Name("mchildren"));

        public UpWebElement InfantsNumber => Driver.FindElement(By.Name("minfant"));

        public UpWebElement DoneChoosingPasengers => Driver.FindElement(By.Id("sumManualPassenger"));

        public UpWebElement SearchForFlights => Driver.FindElement(By.Id("flights"));

        public UpWebElement FlyingClass => Driver.FindElement(By.Name("cabinclass"));

        //search for hotels functions 
        
        public HomePage AirpoirtNameInfo(string airport1,string airport2)
        {
            //CityAirportFrom.Click();


            CityAirportFromInputField.SendKeys("JFK");
         
            CityAirportFromSelection.SendKeys(Keys.Enter);

           // CityAirportTo.Click();
          
            CityAirportTo.SendKeys("Chicago O'Hare");
          //  CityAirportFromInputField.SendKeys(Keys.Down);
            CityAirportTo.SendKeys(Keys.Enter);
            return this;
        }

        public HomePage  DepartureDateFillIn(string date)
        {
            DepartureDate.Clear();
            DepartureDate.Click();
            DepartureDate.SendKeys(date);
            DepartureDate.SendKeys(Keys.Enter);

            return this;
        }

        public HomePage PassengersInfo()
        {
            PassengersSelection.Click();
            AdultsNumber.Clear();
            AdultsNumber.Click();
            AdultsNumber.SendKeys(Keys.Down);
            AdultsNumber.SendKeys(Keys.Down);
            AdultsNumber.SendKeys(Keys.Enter);

            ChildrenNumber.Clear();
            ChildrenNumber.Click();
            ChildrenNumber.SendKeys(Keys.Down);
            
            ChildrenNumber.SendKeys(Keys.Enter);

            InfantsNumber.Clear();
            InfantsNumber.Click();
            InfantsNumber.SendKeys(Keys.Down);
            InfantsNumber.SendKeys(Keys.Enter);
            DoneChoosingPasengers.Click();


            return this;
        }
        public HomePage ChooseClass()
        {
            FlyingClass.Clear();
            FlyingClass.Click();
            FlyingClass.SendKeys(Keys.Down);
            FlyingClass.SendKeys(Keys.Enter);

            return this;
        }
        
        //search for cars functions
        public HomePage SearchPickUpLocationFillIn(string location)
        {
            SearchCarsFormPickUpLocation.Click();
            SearchCarsFormPickUpLocationInputField.Clear();
            SearchCarsFormPickUpLocationInputField.SendKeys("Manchester");
            SearchCarsFormPickUpLocationInputField.SendKeys(Keys.Enter);
            return this;
        }

        public HomePage PickUpDateFillIn(string date){
            PickUpDate.Click();
            PickUpDate.Clear();
            PickUpDate.SendKeys(date);
            return this;
}

        public HomePage PickUpTimeFillIn() {
            PickUpTime.Click();
            PickUpTime.SendKeys(Keys.Down);
            PickUpTime.SendKeys(Keys.Down);
            PickUpTime.SendKeys(Keys.Down);
            PickUpTime.SendKeys(Keys.Down);
            PickUpTime.SendKeys(Keys.Enter);
            return this;
        }

        public HomePage DropOffDateFillIn(string date)
        {
            DropOffDate.Click();
            DropOffDate.Clear();
            DropOffDate.SendKeys(date);
            return this;
        }
           public HomePage DropOffTimeFillIn() { 

            DropOffTime.Click();
            DropOffTime.SendKeys(Keys.Down);
            DropOffTime.SendKeys(Keys.Down);
            DropOffTime.SendKeys(Keys.Enter);


            return this;
        }

        public SearchForCarsPage SearchCars(string date1, string date2, string location = "Manchester")
        {
            CarsSearch.Click();
            SearchPickUpLocationFillIn(location);
            PickUpDateFillIn(date1);
            PickUpTimeFillIn();
            DropOffDateFillIn(date2);
            DropOffTimeFillIn();
            SearchButtonCars.Click();

            return new SearchForCarsPage() { Driver = Driver };

        }

        public SearchFlightsPage SearchFlights(string airport,string airport2, string departure)
        {

            Flights.Click();
            AirpoirtNameInfo(airport,airport2);
            DepartureDateFillIn(departure);
            PassengersInfo();
            FlyingClass.Click();
            SearchForFlights.Click();

            return new SearchFlightsPage() { Driver = Driver };
        }
    }
}
