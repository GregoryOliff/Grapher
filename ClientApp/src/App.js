import React, { Component } from '../../Packages/node-v8.11.3-win-x64/node_modules/react';
import { Route } from '../../Packages/node-v8.11.3-win-x64/node_modules/react-router';
import { Home } from './Components/Home';
import { Layout } from './Components/Layout'

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