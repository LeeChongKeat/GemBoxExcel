# GemBoxExcel
To create the excel from C# by using Gembox. The data is from MSSQL

## Init Project
1) Get the GemBox.spreadsheet Nuget
2) Version v47.0.11

## Create Excel File
1) var workbook = new ExcelFile();

## Create Excel Sheet 
1) workbook.Worksheets.Add("Sheet Name");

## To save the Excel file
1) workbook.Save(stream, SaveOptions.XlsxDefault);

## Download
1) Create Memory Stream => var stream = new MemoryStream();
2) File(stream, "application/force-download", "Writing.xlsx");

## Cell Setting
1) Merged = bool
2) Style = new CellStyle();