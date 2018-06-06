using System;
namespace BIAStudentAppMock
{
    public class InvoiceBuffer
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? ProcessedTime { get; set; }
        public DateTime? LockedTime { get; set; }
        public DateTime? FinishedTime { get; set; }
        public string CompanyId { get; set; }
        public string CompanyYearId { get; set; }
        public string Oznaka { get; set; }
        public string Vrsta { get; set; }
        public string RecNo { get; set; }
        public string RihVatIdBuyer { get; set; }
        public string RihVatIdPublisher { get; set; }
        public string RihInvNum { get; set; }
        public string RihInvDate { get; set; }
        public string RihPayUntil { get; set; }
        public string RihReference { get; set; }
        public string RihGrossV { get; set; }
        public string RihNetV { get; set; }
        public string RihVatV { get; set; }
        public string RihGrossM { get; set; }
        public string RihNetM { get; set; }
        public string RihVatM { get; set; }
        public string RihGross0 { get; set; }
        public string RihNet0 { get; set; }
        public string RihVat0 { get; set; }
        public string RihGross { get; set; }
        public string RihNet { get; set; }
        public string RihVat { get; set; }
        public string FinishedVatIdBuyer { get; set; }
        public string FinishedVatIdPublished { get; set; }
        public string FinishedInvNum { get; set; }
        public string FinishedInvDate { get; set; }
        public string FinishedPayUntil { get; set; }
        public string FinishedReference { get; set; }
        public string FinishedGrossV { get; set; }
        public string FinishedNetV { get; set; }
        public string FinishedVatV { get; set; }
        public string FinishedGrossM { get; set; }
        public string FinishedNetM { get; set; }
        public string FinishedVatM { get; set; }
        public string FinishedGross0 { get; set; }
        public string FinishedNet0 { get; set; }
        public string FinishedVat0 { get; set; }
        public string FinishedGross { get; set; }
        public string FinishedNet { get; set; }
        public string FinishedVat { get; set; }
        public int? LockedBy { get; set; }
        public int? FinishedBy { get; set; }
        public string AdditionalParams { get; set; }
    }
}
