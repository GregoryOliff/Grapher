import React, { Component } from 'react';
import { Col, Grid, Row } from 'react-bootstrap';
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
    
