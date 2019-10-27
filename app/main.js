// Modules to control application life and create native browser window
const {app, BrowserWindow, Menu} = require('electron')
const path = require('path')

// Keep a global reference of the window object, if you don't, the window will
// be closed automatically when the JavaScript object is garbage collected.
let mainWindow

Menu.setApplicationMenu(null);

function createWindow () {
	mainWindow = new BrowserWindow({width: 700,height: 300,})

	mainWindow.loadFile('index.html')

	// mainWindow.webContents.openDevTools()

	mainWindow.on('closed', function () {
		// Dereference the window object, usually you would store windows
		// in an array if your app supports multi windows, this is the time
		// when you should delete the corresponding element.
		mainWindow = null
	})
}

app.on('ready', createWindow)

app.on('window-all-closed', function () {
	app.quit()
})
