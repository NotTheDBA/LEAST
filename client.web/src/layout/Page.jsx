import '../App.css';
import '../tailwind.css';
import Box from './Box'
import Placeholder from '../Placeholder'
import Health from '../views/Health'

function Page() {

    return (
        <Box className={`root content_area`}>
            <Placeholder />
            <Health />
        </Box>
    );

}

export default Page;