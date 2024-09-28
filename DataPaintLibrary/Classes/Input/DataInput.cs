using DataPaintLibrary.Enums;
using System.Collections.Generic;
using System.Data;

namespace DataPaintLibrary.Classes
{
    /// <summary>
    /// Represents the input data configuration for processing.
    /// </summary>
    public class DataInput
    {
        /// <summary>
        /// Gets or sets the unique identifier for the data input.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the data input.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier for the owner group associated with the data input.
        /// </summary>
        public int OwnerGroupId { get; set; }

        /// <summary>
        /// Gets or sets the extraction type of the data input.
        /// </summary>
        public ExtractionType ExtractionType { get; set; }

        /// <summary>
        /// Gets or sets the type of data being input.
        /// </summary>
        public DataType Type { get; set; }

        /// <summary>
        /// Gets or sets the location of the input data.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the DataSet representing the Excel data.
        /// </summary>
        public DataSet ExcelDataSet { get; set; }

        /// <summary>
        /// Gets the list of sheets associated with the data input.
        /// </summary>
        public List<SheetInput> Sheets { get; set; } = new List<SheetInput>();

        /// <summary>
        /// Gets the log of sheet names for tracking.
        /// </summary>
        public List<string> SheetNameLog { get; private set; } = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataInput"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the data input.</param>
        /// <param name="name">The name of the data input.</param>
        /// <param name="ownerGroupId">The identifier for the owner group.</param>
        /// <param name="extractionType">The extraction type of the data input.</param>
        /// <param name="type">The type of data being input.</param>
        /// <param name="location">The location of the input data.</param>
        public DataInput(int id, string name, int ownerGroupId, ExtractionType extractionType, DataType type, string location)
        {
            Id = id;
            Name = name;
            OwnerGroupId = ownerGroupId;
            ExtractionType = extractionType;
            Type = type;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataInput"/> class.
        /// </summary>
        /// <param name="name">The name of the data input.</param>
        /// <param name="ownerGroupId">The identifier for the owner group.</param>
        /// <param name="extractionType">The extraction type of the data input.</param>
        /// <param name="type">The type of data being input.</param>
        /// <param name="location">The location of the input data.</param>
        public DataInput(string name, int ownerGroupId, ExtractionType extractionType, DataType type, string location)
        {
            Name = name;
            OwnerGroupId = ownerGroupId;
            ExtractionType = extractionType;
            Type = type;
            Location = location;
        }
    }
}