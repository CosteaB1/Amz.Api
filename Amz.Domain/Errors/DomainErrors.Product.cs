﻿using Amz.Domain.Shared;

namespace Amz.Domain.Errors
{
    public static partial class DomainErrors
    {
        public static class Product
        {
            public static readonly Error QuantityIsZero = new Error(
                "Product.Create",
                "Quantity can't be zero");

            public static readonly Error NameIsEmpty = new Error(
                "Name.Empty",
                "Name is empty");

            public static readonly Error NameIsTooLong = new Error(
                "Name.TooLong",
                "First name is too long");

            public static readonly Error DescriptionIsEmpty = new Error(
                "Description.Empty",
                "Description is empty");

            public static readonly Error DescriptionIsTooLong = new Error(
                "Description.TooLong",
                "Description is too long");
           
            public static readonly Error OtherDetailsIsTooLong = new Error(
                "Description.TooLong",
                "Description is too long");

            public static readonly Error PriceIsZeroOrLess = new Error(
                "Price.IsZeroOrLess",
                "Price can't be zero or less than zero");
        }
    }
}