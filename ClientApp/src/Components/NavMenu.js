import React, { Component } from '../../../node-v8.11.3-win-x64/node_modules/react';
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
    <!-- Top Bar Content will be under topBar in css file-->
    topBar: (<div className='topBar'>TopBar</div>)
};

export class NavMenu extends Component {
    displayName = NavMenu.name
    
    render() {
        return (
            <Sidebar {sidebarProps}>
                <!-- Main page Content will be under main in css file-->
                <div className='main'>Check out Greg with the Fancy Text</div>
            </Sidebar>        
        )
    }
}