import React from "react";
import './LoginComponent.css';
import BaseComponent from "./BaseComponent";

export default class LoginComponent extends BaseComponent {
    constructor(props) {
        super(props);
        this.state = {
            name: "",
            password: ""
        };
        this.onSubmit = this.onSubmit.bind(this);
    }

    onSubmit(event) {
        event.preventDefault();
        this.props.onSubmit(this.state);
    }

    render() {
        return <form className="form">
            <h1>Login</h1>
            <label htmlFor="name">Name</label>
            <input type="text" id="name" value={this.state.name} onChange={this.onTextBoxChange} />
            <label htmlFor="password">Password</label>
            <input type="password" id="password" value={this.state.password} onChange={this.onTextBoxChange} />
            <button onClick={this.onSubmit}>Continue</button>
        </form>
    }
}