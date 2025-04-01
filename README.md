# Global Land and Ocean Average Temperature Anomalies in WPF HeatMap
In this blog, we’ll explore how to create a WPF Heat Map using [Syncfusion Heatmap Chart](https://www.syncfusion.com/wpf-controls/heatmap) control. We will also demonstrate how to customize tooltips to enhance user interaction, providing detailed insights when hovering over specific data points. Our dataset will focus on global land and ocean average temperature anomalies from 2004 to 2024, helping us observe climate trends over time.

## Heat Map 
A [Heat Map](https://help.syncfusion.com/wpf/heatmap/getting-started) is a graphical representation where data points are color-coded based on their values. This visualization is particularly useful for:
- Analyzing long-term climate trends, financial fluctuations, and healthcare data.
- Quickly identifying patterns, outliers, and regional variations.
- Representing relationships between variables in a structured grid format.
 
## Binding Data to the Heat Map
The TemperatureViewModel is set as the DataContext, and the temperature data is bind to the heat map using the ItemsSource property. The mapping of each month's temperature is defined in the TableMapping resource, linking the Year and each month's data (e.g., January, February, etc.). The ItemsMapping are used to bind the model to Heat Map.

## Customizing Heat Map Appearance
we'll focus on customizing the appearance of the heat map based on the cell values to enhance the visualization.
## Color Mapping:
To improve the visual representation of data, we can map specific temperature values to a range of colors. Syncfusion’s WPF Heat Map offers a ColorMappingCollection that allows you to assign different colors to specific data values. We define a collection of color mappings where each value corresponds to a particular color. The values will then be reflected in the heat map cells, making it easier to understand temperature anomalies.
Here’s an example of a ColorMappingCollection that defines colors based on temperature values, where lower values are represented with cooler colors and higher values with warmer colors:

## Output


## Troubleshooting
### Path Too Long Exception
If you are facing a **Path too long** exception when building this project, follow these steps:
1. Close Visual Studio.
2. Rename the repository to a shorter name.
3. Reopen the project and build again.

For a step-by-step guide, refer to [WPF Heat Map to Display Global Land and Ocean Temperature Anomalies (2004–2024)]()