import React, { Component } from '../../../node-v8.11.3-win-x64/node_modules/react';
import { Link } from '../../../node-v8.11.3-win-x64/node_modules/react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from '../../../node-v8.11.3-win-x64/node_modules/react-bootstrap';
import { LinkContainer } from '../../../node-v8.11.3-win-x64/node_modules/react-router-bootstrap';
import Sidebar from '../../../node-v8.11.3-win-x64/node_modules/react-side-bar';
import './NavMenu.css';

const sidebarProps = {
    bar: (<div>BestDamnSidebar</div>),
    size: 200,
    opened: this.state.opened,
    onClose: () => {
        setState({opened: false})
    },
    onOpen: () => {
        setState({opened: true})
    },
    topBar: (<div className='topBar'>BestDamnTopbar</div>)
};

export class NavMenu extends Component {
    displayName = NavMenu.name
    
    render() {
        return (
            <Navbar inverse fixedTop fluid collapseOnSelect>
                <Navbar.Header>
                    <Navbar.Brand>
                        <Link to={'/'}>ALE</Link>
                    </Navbar.Brand>
                    <Navbar.Toggle />
                </Navbar.Header>
                <Navbar.Collapse>
                    <Nav>
                        <LinkContainer to={'/'} exact>
                            <NavItem>
                                <Glyphicon glyph='home' /> Home
                            </NavItem>
                        </LinkContainer>S
                    </Nav>
                </Navbar.Collapse>
                <Sidebar {sidebarProps} />
            </Navbar>
        )
    }
}