import React from "react";
import "./LoginAttemptList.css";
import LoginAttempt from "./LoginAttempt";
import BaseComponent from "./BaseComponent";

export default class LoginAttemptList extends BaseComponent {

	constructor(props) {
		super(props);
		this.state = this.createInitialState();
		this.renderLoginAttempts = this.renderLoginAttempts.bind(this);
		this.clearFilter = this.clearFilter.bind(this);
	}
	
	createInitialState() {
		return {
			filter: "",
		}
	}
	
	renderLoginAttempts() {
		const filter = this.state.filter;
		const data = this.props.attempts;
		const filteredData = data.filter(a => a.name.includes(filter));
		return filteredData.map(a => {
			return <LoginAttempt value={a}/>;
		});
	}

	clearFilter() {
		this.setState(this.createInitialState());
	}
	
	render() {
		return <div className="Attempt-List-Main">
			<p>Recent activity</p>
			<div>
				<input
					id="filter"
					type="text"
					placeholder="Filter by Name..."
					value={this.state.filter}
					onChange={this.onTextBoxChange}
				/>
				<input type="button" value="Clear" onClick={this.clearFilter} />
			</div>
			<ul className="Attempt-List">
				{this.renderLoginAttempts()}
			</ul>
		</div>
	}
}
