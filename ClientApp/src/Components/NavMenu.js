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
    }
};

export class NavMenu extends Component {
    displayName = NavMenu.name
    
    render() {
        return (
            <Sidebar {sidebarProps}>
                <!-- Top Bar Content will be under topBar in css file-->
                <div className='topBar'>SideBar</div>
                <!-- Main page Content will be under main in css file-->
                <div className='main'>main</div>
            </Sidebar>        
        )
    }
}