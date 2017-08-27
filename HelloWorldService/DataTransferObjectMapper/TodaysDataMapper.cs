using System.Collections.Generic;
using System.Linq;
using BusinessObjects.TodaysData;
using HelloWorldService.DataTransferObjects;

namespace HelloWorldService.DataTransferObjectMapper
{
    public static class TodaysDataMapper
    {
        /// <summary>
        /// Maps DTOs (Data Transfer Objects) to BOs (Business Objects) and vice versa.
        /// </summary>
        public static partial class Mapper
        {
            /// <summary>
            /// Transforms list of TodaysData BOs to list of TodaysData DTOs.
            /// </summary>
            /// <param name="TodaysData">List of TodaysData BOs.</param>
            /// <returns>List of TodaysData DTOs.</returns>
            public static TodaysDataDto ToDataTransferObject(TodaysData todaysData)
            {
                if (todaysData == null) return null;
                return new TodaysDataDto
                {
                    Data = todaysData.Data
                };
            }

            /// <summary>
            /// Transforms TodaysData BO to TodaysData DTO.
            /// </summary>
            /// <param name="TodaysDatas">TodaysData BO.</param>
            /// <returns>TodaysData DTO.</returns>
            public static IList<TodaysDataDto> ToDataTransferObjects(IEnumerable<TodaysData> todaysData)
            {
                if (todaysData == null) return null;
                return todaysData.Select(c => ToDataTransferObject(c)).ToList();
            }

            // <summary>
            /// Transfers TodaysData DTO to Vat Returns BO.
            /// </summary>
            /// <param name="TodaysData">TodaysData DTO.</param>
            /// <returns>TodaysData BO.</returns>
            public static TodaysData FromDataTransferObject(TodaysDataDto todaysData)
            {
                if (todaysData == null) return null;

                return new TodaysData
                {
                    Data = todaysData.Data
                };
            }

            /// <summary>
            /// Transforms list of TodaysData BOs to list of Customer DTOs.
            /// </summary>
            /// <param name="TodaysData">List of TodaysData BOs.</param>
            /// <returns>List of TodaysData DTOs.</returns>
            public static IList<TodaysData> FromDataTransferObjects(IEnumerable<TodaysDataDto> todaysData)
            {
                if (todaysData == null) return null;
                return todaysData.Select(c => FromDataTransferObject(c)).ToList();
            }

        }
    }
}
