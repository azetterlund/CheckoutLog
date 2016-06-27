using System;

namespace Checkout.Models
{
    public class TransData
    {
        public int TransactionId { get; set; }
        public int TransactionTypeid { get; set; }
        public string TransactionUID { get; set; }
        public int TUserId { get; set; }
        public float Total { get; set; }
        public float ProcessingFee { get; set; }
        public float AdditionalFee { get; set; }
        public string Created { get; set; }
        public string Completed { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public int AcctNumber { get; set; }
        public string ProcessorType { get; set; }
        public string Custom { get; set; }
        public string CardType { get; set; }
        public string CCExpirationDate { get; set; }
        public bool Success { get; set; }
        public bool DisputeData { get; set; }

        public int UserId { get; set; }
        public int AssociationId { get; set; }
        public string UserKey { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Internal { get; set; }
        public bool Temporary { get; set; }
        public string UserCreated { get; set; }

        public int ErrorId { get; set; }
        public string ErrorKey { get; set; }
        public int ETransactionId { get; set; }
        public string LongErrorMessage { get; set; }
        public string ErrorCode { get; set; }
        public string ShortErrorMessage { get; set; }
        public string Error { get; set; }
        public string StackTrace { get; set; }
    }
}