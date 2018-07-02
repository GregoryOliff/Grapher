import '../../node-v8.11.3-win-x64/node_modules/bootstrap/dist/css/bootstrap.css';
import '../../node-v8.11.3-win-x64/node_modules/bootstrap/dist/css/bootstrap-theme.css'
import './index.css';
import React from '../../Packages/node-v8.11.3-win-x64/node_modules/react';
import ReactDOM from '../../Packages/node-v8.11.3-win-x64/node_modules/react-dom';
import { BrowserRouter } from '../../Packages/node-v8.11.3-win-x64/node_modules/react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
    <BrowserRouter basename={baseUrl}>
        <App />
    </BrowserRouter>,
    rootElement);

registerServiceWorker();
