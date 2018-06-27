import React, { Component } from '../../node-v8.11.3-win-x64/node_modules/react';
import { Route } from '../../node-v8.11.3-win-x64/node_modules/react-router';
import { Home } from './Components/Home';

export default class App extends Component {
    displayName = App.name
    
    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
            </Layout>
        )
    }
}