import React, { Component } from 'react';

export class Home extends Component {
    displayName = Home.name
    
    render() {
        return (
            <div>
                <h1>Hello, World!</h1>
                <p>Welcome to a single page application used to demonstrate the power of GraphQL, C3/D3, and React!!</p>
            </div>
        )
    }
}