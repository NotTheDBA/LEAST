import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [healthChecks, setHealthChecks] = useState();

    useEffect(() => {
        populateHealthData();
    }, []);

    const contents = healthChecks === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tableLabel">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Service</th>
                    <th>Summary</th>
                </tr>
            </thead>
            <tbody>
                {healthChecks?.map(healthCheck =>
                    <tr key={healthCheck.date}>
                        <td>{healthCheck.date}</td>
                        <td>{healthCheck.service}</td>
                        <td>{healthCheck.summary}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tableLabel">System Health Checks</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
        </div>
    );
    
    async function populateHealthData() {
        const response = await fetch('health');
        if (response.ok) {
            const data = await response.json();
            setHealthChecks(data);
        }
    }
}

export default App;