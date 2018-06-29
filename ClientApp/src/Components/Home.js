import React, { Component } from '../../../node-v8.11.3-win-x64/node_modules/react';
//import { graphql } from '../../../node-v8.11.3-win-x64/node_modules/graphql'
import  flight  from '../../../Grapher.Core/Models/Flight.cs';
import gql from '../../../node-v8.11.3-win-x64/node_modules/graphql-tag'

let speedData;

flight.query ({
    query: gql `
        query GrapherQuery {
           flight( name = "flight1" ){
               recordedSpeeds
           } 
        }
    `
}) .then(speedData  = response.data)

var chart = c3.generate({
    data:{
        columns:[
            ['data1', speedData]
        ],    
        name: {
            data1: 'X = Time, Y = Speed (mph)'
        }
    }
});

export class Home extends Component {
    displayName = Home.name
    
    render() {
        return (
            <div>
                <h1>Hello, World!</h1>
                <p>Welcome to a single page application used to demonstrate the power of GraphQL, C3/D3, and React!!</p>
                <p>Check out this graph I made by pulling in data with GraphQL, and making the chart itself with C3/D3</p>
                <div content={chart} />
            </div>
        )
    }
}