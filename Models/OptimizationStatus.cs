namespace LogiRoute.Models
{
    public enum OptimizationStatus
    {
        Optimal,
        FeasibleStateLimitReached,
        StateLimitReached,
        NoProducts,
        NoTrucks,
        DuplicateProductIds,
        DuplicateTruckIds,
        InvalidInput,
        MandatoryProductDoesNotFit,
        MandatoryAllocationImpossible,
        Cancelled,
        InternalError
    }
}
