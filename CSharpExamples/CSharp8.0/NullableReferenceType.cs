using System;
namespace CSharp8._0
{
    public class NullableReferenceType
    {
        //C# 8.0 introduces nullable reference types and non-nullable reference types that enable you to make important statements about the properties for reference type variables:

        //A reference isn't supposed to be null. When variables aren't supposed to be null, the compiler enforces rules that ensure it's safe to dereference these variables without first checking that it isn't null:
        //      The variable must be initialized to a non-null value.
        //      The variable can never be assigned the value null.
        //A reference may be null. When variables may be null, the compiler enforces different rules to ensure that you've correctly checked for a null reference:
        //      The variable may only be dereferenced when the compiler can guarantee that the value isn't null.
        //      These variables may be initialized with the default null value and may be assigned the value null in other code.
        //To enable the feature, you must add the following line in the project file(csproj) PropertyGroup: or nullable annotation context in each file of project
        public NullableReferenceType()
        {
        }

        public class Address
        {
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
        }
        #nullable enable

        public Address? FromAddress { get; set; }

        public void NullableReferenceTypeSyntax(Address address)
        {
             this.FromAddress = address;
        }

        public string GetCity()
        {
            //Null forgive operator
            //if you know the FromAddress property variable isn't null but the compiler issues a warning, you can write the following code to override the compiler's analysis:
            return this.FromAddress!.City;
        }
    
    }
}
