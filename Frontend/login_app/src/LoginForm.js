import React from "react";
import LoginAttemptList from "./LoginAttemptList";
import LoginComponent from "./LoginComponent";

export default class LoginForm extends React.Component {
	constructor(props) {
		super(props);
		this.state = {
			loginAttempts: [],
		};
		this.onSubmit = this.onSubmit.bind(this);
	}

	onSubmit(params) {
		const loginAttempts = this.state.loginAttempts;
		loginAttempts.push({ name: params.name, password: params.password });
		this.setState({ loginAttempts: loginAttempts });
	}
	
	render() {
		return <React.Fragment>
			<LoginComponent onSubmit={this.onSubmit} />
			<LoginAttemptList attempts={this.state.loginAttempts} />			
		</React.Fragment>;
	}
}