import React, { Component } from '../../../Packages/node-v8.11.3-win-x64/node_modules/react';
import { Col, Grid, Row } from '../../../Packages/node-v8.11.3-win-x64/node_modules/react-bootstrap';
import { NavMenu } from './NavMenu';

export class Layout extends Component {
    displayName = Layout.name
    
    render() {
        return (
            <Grid fluid>
                <Row>
                    <Col sm={3}>
                        <NavMenu />
                    </Col>
                    <CoL sm={9}>
                        {this.props.children}
                    </CoL>    
                </Row>
            </Grid>    
        );
    }
}
    
