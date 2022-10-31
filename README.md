# OscilloscopeTool
## *Portable Windows app to extract and plot data from R&S RTB2000 series oscilloscopes*
***v 1.0.1***

[Download Latest](https://github.com/zceechu/OscilloscopeTool/releases)

***If the program is being blocked for some reason e.g. institution computer, copy the project into Visual Studio and build a release***

# Guide

![image](https://user-images.githubusercontent.com/95242484/198991366-09ba7e15-997f-44d0-a03a-70aac968879d.png)

- **Browse**
> Navigate to the parent directory where the data and plots folder will be saved

- **Test Name**
> Name the test for the data that is being grabbed, or refer to the data to be plotted

> When extracting data, the created folder will be named after this test
> If left empty, will default to the name "Test"

- **Channels**
> Checkbox to select which channels to read from, and to plot against time

- **Get Data**
> Extracts .csv data from the oscilloscope (via MTP) and places it into the browsed directory, with the file structure below

- **Get Screenshot**
> Extracts SCREENSHOT.png from the oscilloscope (via MTP) and places it into the browsed directory, with the file structure below

- **Plot (Time)**
> Plots the selected channels against time via matplotlib, and save a .png in the browsed directory, with the file structure below

> Requires the data the be extracted, then finds it via the test name and parent directory

- **Plot (Time)**
> Plots the selected channels against each other via matplotlib, and save a .png in the browsed directory, with the file structure below

> Requires the data the be extracted, then finds it via the test name and parent directory

- **Plot Options**
> Allows the plot parameters to be adjusted, starts with default values

- **Title, X Label and Y Label**
> Allows custom title, X label and Y label for the plot

> If left empty, generates some default names

- **Plot Display**
> The top right space will display the plots in the test folder

> These plots can be navigated using the left right buttons, or the drop down menu

> Hitting the refresh button will update the plot list

# File structure
```
TestName (User Input)
- Data
    - CH1.csv
    - CH2.csv
    ...
- plots
    - TestName-tplot-CH(X).png
    - TestName-xyplot-CH(X)-CH(Y).png
    ...
SCREENSHOT.png
...
```

# Notes
- Currently works only for the R&S oscilloscope, can be adapted for any MTP device
- Plotting options are not fully fleshed out
- Python backend perhaps should be superceded by C# code
