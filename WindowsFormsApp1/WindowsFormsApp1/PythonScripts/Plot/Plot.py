import sys
import os
import json
import pandas as pd
import matplotlib
matplotlib.use('wxagg')
import matplotlib.pyplot as plt

#TODO:: error checking

filePath = sys.argv[1]
testName = sys.argv[2]
channels = []
if sys.argv[3] != "":
    channels = [i for i in sys.argv[3].split(",")]
combos = json.loads(sys.argv[4])
#combos = json.loads("""
#{
#    "1":["2"],
#    "2":["1"]
#}
#""")

plotOptions = json.loads(sys.argv[5])
#plotOptions = json.loads("""
#{
#    "Color":"#0072BD",
#    "LineStyle":"-",
#    "LineWidth":0.5,
#    "Marker":"none",
#    "MarkerEdgeColor":"auto",
#    "MarkerFaceColor":"none",
#    "MarkerSize":6,
#    "xlabel":"Default",
#    "ylabel":"Default",
#    "title":"Default"
#}
#"""

if not os.path.exists(filePath + '/plots'):
    os.makedirs(filePath + '/plots')

def plotChannels():
    for channel in channels:
        channelData = pd.read_csv(filePath + '/Data/' + 'CH'+channel+'.csv')
    
        channelData.plot(x = "in s",
                         y = "C"+channel+" in V",
                         ls = plotOptions['LineStyle'],
                         c = plotOptions['Color'],
                         lw = plotOptions['LineWidth'],
                         marker = plotOptions['Marker'],
                         mec = plotOptions['MarkerEdgeColor'],
                         mfc = plotOptions['MarkerFaceColor'],
                         ms = plotOptions['MarkerSize'])

        if plotOptions['xlabel'] == 'Default':
            plt.xlabel('Time (s)')
        else:
            plt.xlabel(plotOptions['xlabel'])
        if plotOptions['ylabel'] == 'Default':
            plt.ylabel('Voltage (V)')
        else:
            plt.ylabel(plotOptions['ylabel'])
        if plotOptions['title'] == 'Default':
            plt.title(testName+' on Channel '+channel)
        else:
            plt.title(plotOptions['title'])

        testNameDashed = testName.replace('\s', '-')
        filename = testNameDashed+'-tplot-CH'+channel+'.png'
        
        plt.savefig(filePath + '/plots/' + filename)

def plotCombos():
    for x in combos:
        xData = pd.read_csv(filePath + '/Data/' + 'CH'+x+'.csv')
        for y in combos[x]:
            yData = pd.read_csv(filePath + '/Data/' + 'CH'+y+'.csv')
            df = pd.concat([xData, yData], axis=1, join="outer")
            df.plot(x = "C"+x+" in V",
                             y = "C"+y+" in V",
                             ls = plotOptions['LineStyle'],
                             c = plotOptions['Color'],
                             lw = plotOptions['LineWidth'],
                             marker = plotOptions['Marker'],
                             mec = plotOptions['MarkerEdgeColor'],
                             mfc = plotOptions['MarkerFaceColor'],
                             ms = plotOptions['MarkerSize'])

            if plotOptions['xlabel'] == 'Default':
                plt.xlabel('CH'+x+' Voltage (V)')
            else:
                plt.xlabel(plotOptions['xlabel'])
            if plotOptions['ylabel'] == 'Default':
                plt.ylabel('CH'+y+' Voltage (V)')
            else:
                plt.ylabel(plotOptions['ylabel'])
            if plotOptions['title'] == 'Default':
                plt.title('CH'+x+' against CH'+y)
            else:
                plt.title(plotOptions['title'])

            testNameDashed = testName.replace('\s', '-')
            filename = testNameDashed+'-xyplot-CH'+x+'-CH'+y+'.png'
            
            plt.savefig(filePath + '/plots/' + filename)

plotChannels()
plotCombos()
