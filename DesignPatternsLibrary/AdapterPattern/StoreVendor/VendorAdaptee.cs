using System.Collections.Generic;

namespace AdapterPattern
{
    
    //Adapter Pattern overview
        //A class that would be useful to your application does not implement the interface you require
        //You are designing a class or a frmaework adn you want to ensure it is usable by a wide variety of as-yet-unwritten classes and applications
        //Adapters are also commonly known as Wrappers
        //This only covers object adapters, which do not require multiple inheritance as class adapters do.
        //Converts the interface of a class nto another interface clients expect.
        //Allow classes to work together that couldn't otherwise due to incompatibel inteerfaces
        //Futer-proof client implementations by having them depend on Adapter interfaces, rather than concrete classes direclty

    //When to use
        //You want to use and existing class, but it's interface does not match the one you require
        //You want to create a reusable class that cooperates with urelated or unforeseen classes
        //You need to use several existing subclasses, but it's impractical to adapt their existing interface by subclassing every one.

    //How it's used
        //Clients depend on the Adapter interface, rather than a particular impementation
        //At least one concrete adapter class is created to allow the client to work with a particular class that it requires
        //Future client needs for alternate implementations can be satisfied throught the creation of additional concrete Adapter classes.
        //Effective way to achieve Open/Closed principle

    //Collaboration
        //Clients call operations on an Adapter instance
        //Adapter instance calls Adaptee operations that carry out the request

    //Consequences
        //A single Adapter interface may work with many Adaptees
            //One Adaptee and all of it's subclasses
            //Seperate Adaptees via separate concrete Adapter implementations
        //Can be difficult to override Adaptee behavior (with Object Adapter)
            //Must sublass adaptee and add overriden behavior
            //Then, change concrete adapter implementation to refer to Adaptee subclass

    public class VendorAdaptee
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();
            products.Add("Gaming Consoles");
            products.Add("Television");
            products.Add("Books");
            products.Add("Musical Instruments");
            return products;
        }
    }
}
