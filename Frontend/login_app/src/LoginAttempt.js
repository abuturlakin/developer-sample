import React from "react";

export default class LoginAttempt extends React.Component {
    render() {
        const value = this.props.value;
        return <li>
            <label>Name: {value.name} | Password: {value.password}</label>
        </li>;
    }
}