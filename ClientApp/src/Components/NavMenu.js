import React, { Component } from '../../../Packages/node-v8.11.3-win-x64/node_modules/react';
import Sidebar from '../../../Packages/node-v8.11.3-win-x64/node_modules/react-side-bar';
import { NavItem, Button, Glyphicon} from '../../../Packages/node-v8.11.3-win-x64/node_modules/react-bootstrap';
import { LinkContainer } from '../../../Packages/node-v8.11.3-win-x64/node_modules/react-router-bootstrap';
import './NavMenu.css';

const sidebarProps = {
    bar: (<LinkContainer to={'/'} exact>
            <NavItem>
                <Button bsSize="large" >
                    <Glyphicon glyph='home'/>Home
                </Button>    
            </NavItem>
          </LinkContainer>),
    size: 200,
    opened: this.state.opened,
    onClose: () => {
        setState({opened: false})
    },
    onOpen: () => {
        setState({opened: true})
    },
    toggleBar: () => {
        if (this.state.opened) {this.onClose()} 
        else {this.onOpen()}
    },
    <!-- Top Bar Content will be under #topBar in css file-->
    topBar: (<div className='topBar'>Hawkeye
                <div onClick={this.toggleBar.bind(this)}>
                    <Glyphicon glyph='glyphicon-menu-hamburger' />Menu
                </div>
                <div className='WidgetsButton'>
                    <Button className='button'>Widgets</Button>
                </div>
             </div>)
};

export class NavMenu extends Component {
    displayName = NavMenu.name
    
    render() {
        return (
            <Sidebar {sidebarProps}>
                <!-- Main page Content will be under #main in css file-->
                <div className='main'>Check out Greg with the Fancy Text</div>
            </Sidebar>        
        )
    }
}