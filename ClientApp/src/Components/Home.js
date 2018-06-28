import React, { Component } from '../../../node-v8.11.3-win-x64/node_modules/react';

export class Home extends Component {
    displayName = Home.name
    
    render() {
        return (
            <div>
                <h1>Hello, World!</h1>
                <p>Welcome to a single page application used to demonstrate the power of GraphQL, C3/D3, and React!!</p>
                <p>Check out this graph I made by pulling in data with GraphQL, and making the chart itself with C3/D3</p>
            </div>
        )
    }
}